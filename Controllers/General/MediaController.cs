using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace AgrixemAPI.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IHostEnvironment hostEnvironment;
        //Summary
        /*						  
         Tasks 4 modes
         1.  Focus[users]-[ID]-[Title] for users(verified)
         2.  Focus[farms]-[Id]-[Title]-FormType[farm]-extension for whole farm pics (verified)
         3.  Focus[farms]-[Id]-[Title]-FormType[animals]-AnimalType[Cattle]-Mode[Many]-extension for photos with many animals in them. many for animals in the same picture. (verified)
         4.  Focus[farms]-[Id]-[Title]-FormType[animals]-AnimalType[Cattle]-Mode[Single]-[AnimalID]-extension for animals with sinle images
        */
        public MediaController(IHostEnvironment Environment)
        {
            //get access to wwwroot folder
            hostEnvironment = Environment;
        }

        #region Add Photos
        [HttpPost()]
        public async Task<IActionResult> PostMedia(
            [FromForm] IFormFile Picture,
            [FromForm] string Focus,
            [FromForm] string ID,
            [FromForm] string Title,
            [FromForm] string FormType,
            [FromForm] string AnimalType,
            [FromForm] string Mode,
            [FromForm] string AnimalID
            )
        {

            string[] allowedImageTypes = { ".png", ".jpeg", ".jpg" };
            //check if file was fully uploaded
            if (Picture.Length == 0 || Picture == null)

                return BadRequest("Upload  a New File");


            //Check if it is an image
            string imageName = Picture.FileName;

            string imageExtension = Path.GetExtension(imageName);

            if (!allowedImageTypes.Contains(imageExtension))

                return BadRequest("File Type not Accepted");



            //get main directory for images
            string mainDictory = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", "media");

            //create for user
            //check if that folder exists if it doesn't create it
            if (Focus == "users" || Focus == "Users")
            {
                string userFolderPath = Path.Combine(mainDictory, "users", ID);

                if (!Directory.Exists(userFolderPath))

                    Directory.CreateDirectory(userFolderPath);

                string newFileName = Title;

                string filePath = Path.Combine(userFolderPath, newFileName);

                using (var filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    await Picture.CopyToAsync(filestream);
                }

                return Ok($"{newFileName}'s Profile Photo Saved");

            }
            else if (Focus == "Farms" || Focus == "farms")
            {
                //Focus on farms
                string specialFolderPath = Path.Combine(mainDictory, "Farms", ID);

                if (!Directory.Exists(specialFolderPath))

                    Directory.CreateDirectory(specialFolderPath);

                //Deal with farm pictures
                if (FormType == "Farm" || FormType == "farm")
                {
                    string farmFolderPath = Path.Combine(specialFolderPath, "Farm");
                    if (!Directory.Exists(farmFolderPath))

                        Directory.CreateDirectory(farmFolderPath);

                    string newFileName = $"{Title}{imageExtension}";

                    string filePath = Path.Combine(farmFolderPath, newFileName);

                    using (var filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        await Picture.CopyToAsync(filestream);
                    }

                    return Ok($"{newFileName} Saved to Farm Folder");
                }
                //Deal with animals
                else if (FormType == "Animals" || FormType == "animals")
                {
                    //animals folder
                    string animalFolderPath = Path.Combine(specialFolderPath, "Animals");
                    if (!Directory.Exists(animalFolderPath))

                        Directory.CreateDirectory(animalFolderPath);

                    //make folders based on animal type
                    if (AnimalType == "Cattle" || AnimalType == "cattle")
                    {
                        //Cattle folder
                        string cattleFolderPath = Path.Combine(animalFolderPath, "Cattle");

                        if (!Directory.Exists(cattleFolderPath))

                            Directory.CreateDirectory(cattleFolderPath);

                        //Check many of single ID;
                        if (Mode == "Many" || Mode == "many")
                        {
                            //Kraal folder
                            string KraalFolderPath = Path.Combine(cattleFolderPath, "Kraal");

                            if (!Directory.Exists(KraalFolderPath))

                                Directory.CreateDirectory(KraalFolderPath);

                            string newFileName = $"{Title}{imageExtension}";

                            string filePath = Path.Combine(KraalFolderPath, newFileName);

                            using (var filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                            {
                                await Picture.CopyToAsync(filestream);
                            }
                            return Ok($"{newFileName} Saved to Cattle Folder");

                        }
                        else if (Mode == "Single" || Mode == "single")
                        {
                            string singleFolderPath = Path.Combine(cattleFolderPath, "Ids");

                            if (!Directory.Exists(singleFolderPath))
                            {
                                Directory.CreateDirectory(singleFolderPath);
                            }
                            string finalPath = Path.Combine(singleFolderPath, AnimalID);

                            if (!Directory.Exists(finalPath))
                            {
                                Directory.CreateDirectory(finalPath);
                            }

                            string newFileName = $"{Title}{imageExtension}";

                            string filePath = Path.Combine(finalPath, newFileName);

                            using (var filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                            {
                                await Picture.CopyToAsync(filestream);
                            }
                            return Ok($"{newFileName} Saved to Cow's Folder");
                        }
                        else
                        {
                            return BadRequest("The cows might lost have lost their folders, Sorry.");
                        }

                    }
                    else if (AnimalType == "Goats" || AnimalType == "goats")
                    {
                        //Goats folder
                        string goatsFolderPath = Path.Combine(animalFolderPath, "Goats");

                        if (!Directory.Exists(goatsFolderPath))

                            Directory.CreateDirectory(goatsFolderPath);

                        //Check many of single ID;
                        if (Mode == "Many" || Mode == "many")
                        {
                            //Kraal folder
                            string KraalFolderPath = Path.Combine(goatsFolderPath, "Kraal");

                            if (!Directory.Exists(KraalFolderPath))
                            {
                                Directory.CreateDirectory(KraalFolderPath);
                            }

                            string newFileName = $"{Title}{imageExtension}";

                            string filePath = Path.Combine(KraalFolderPath, newFileName);

                            using (var filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                            {
                                await Picture.CopyToAsync(filestream);
                            }
                            return Ok($"{newFileName} is now Saved to Goats Folder");


                        }
                        else if (Mode == "Single" || Mode == "single")
                        {
                            string singleFolderPath = Path.Combine(goatsFolderPath, "Ids");

                            if (!Directory.Exists(singleFolderPath))
                            {
                                Directory.CreateDirectory(singleFolderPath);
                            }
                            string finalPath = Path.Combine(singleFolderPath, AnimalID);

                            if (!Directory.Exists(finalPath))
                            {
                                Directory.CreateDirectory(finalPath);
                            }

                            string newFileName = $"{Title}{imageExtension}";

                            string filePath = Path.Combine(finalPath, newFileName);

                            using (var filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                            {
                                await Picture.CopyToAsync(filestream);
                            }
                            return Ok($"{newFileName} is saved to this Goats' Folder");
                        }
                        else
                        {
                            return BadRequest("Forgive us, the Goats folder couldn't be located");
                        }


                    }
                    else if (AnimalType == "Pigs" || AnimalType == "pigs")
                    {
                        //Pigs folder
                        string pigsFolderPath = Path.Combine(animalFolderPath, "Pigs");

                        if (!Directory.Exists(pigsFolderPath))

                            Directory.CreateDirectory(pigsFolderPath);

                        //Check many of single ID;
                        if (Mode == "Many" || Mode == "many")
                        {
                            //Kraal folder
                            string KraalFolderPath = Path.Combine(pigsFolderPath, "Kraal");

                            if (!Directory.Exists(KraalFolderPath))

                                Directory.CreateDirectory(KraalFolderPath);

                            string newFileName = $"{Title}{imageExtension}";

                            string filePath = Path.Combine(KraalFolderPath, newFileName);

                            using (var filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                            {
                                await Picture.CopyToAsync(filestream);
                            }

                            return Ok($"{newFileName} saved to Pigs Folder");

                        }
                        else if (Mode == "Single" || Mode == "single")
                        {
                            string singleFolderPath = Path.Combine(pigsFolderPath, "Ids");

                            if (!Directory.Exists(singleFolderPath))

                                Directory.CreateDirectory(singleFolderPath);

                            string finalPath = Path.Combine(singleFolderPath, AnimalID);

                            if (!Directory.Exists(finalPath))

                                Directory.CreateDirectory(finalPath);

                            string newFileName = $"{Title}{imageExtension}";

                            string filePath = Path.Combine(finalPath, newFileName);

                            using (var filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                            {
                                await Picture.CopyToAsync(filestream);
                            }

                            return Ok($"{newFileName} saved to this Pigs' Folder");
                        }
                        else

                            return BadRequest("Dirty Pigs, We couldn't See the Folder...");


                    }
                    else if (AnimalType == "Chicken" || AnimalType == "chicken")
                    {
                        //Chicken folder
                        string chickenFolderPath = Path.Combine(animalFolderPath, "Chicken");

                        if (!Directory.Exists(chickenFolderPath))

                            Directory.CreateDirectory(chickenFolderPath);

                        //Check many of single ID;
                        if (Mode == "Many" || Mode == "many")
                        {
                            //Kraal folder
                            string KraalFolderPath = Path.Combine(chickenFolderPath, "Kraal");

                            if (!Directory.Exists(KraalFolderPath))

                                Directory.CreateDirectory(KraalFolderPath);

                            string newFileName = $"{Title}{imageExtension}";

                            string filePath = Path.Combine(KraalFolderPath, newFileName);

                            using (var filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                            {
                                await Picture.CopyToAsync(filestream);
                            }

                            return Ok($"{newFileName} Saves to this Batches Folder");

                        }
                        else if (Mode == "Single" || Mode == "single")

                            return BadRequest("We never store pics for single chickens, ever.");

                        else

                            return BadRequest("Sorry, that Chicken found, yes that one... We couldn't find it.");
                    }
                    else return BadRequest("This Animal, We don't know what it is...");

                }
                else return BadRequest("Unclear Photo, We can't tell if its an Animal or Landscape");

            }
            else return BadRequest("Exteremely bad image format, Give Up...This will never be.");



        }
        #endregion

        #region Get Photo Names
        // GET [User]: api/media/users/id
        [HttpGet("users/{id}")]
        public ActionResult<IEnumerable<string>> GetUsers(string id)
        {
            string mainDictory = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", "media");
            string UserDictiory = Path.Combine(mainDictory, "users", id);


            if (Directory.Exists(UserDictiory))

                return ProcessDirectory(UserDictiory);

            return new List<string>() { };
        }

        // GET [Farms]: api/media/farms/{id}/farm
        [HttpGet("farms/{id:int}/farm")]
        public ActionResult<IEnumerable<string>> GetMedia(int id)
        {
            string mainDictory = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", "media");
            string ID = id.ToString();

            string farmDictiory = Path.Combine(mainDictory, "farms", ID, "Farm");

            if (Directory.Exists(farmDictiory))

                return ProcessDirectory(farmDictiory);

            return new List<string>() { };
        }

        // GET[Animals Group]: api/media/farms/{id}/animals/{animalType}/many
        [HttpGet("farms/{id}/animals/{animalType}/many")]
        public ActionResult<IEnumerable<string>> GetMedia(int id, string animalType)
        {
            string mainDictory = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", "media");
            string ID = id.ToString();

            string farmDictiory = Path.Combine(mainDictory, "farms", ID, "animals");
            string manyAnimals = Path.Combine(farmDictiory, animalType, "kraal");

            if (Directory.Exists(manyAnimals))

                return ProcessDirectory(manyAnimals);

            return new List<string>() { };
        }

        // GET[Animals Single]: api/media/farms/{id}/animals/{animalType}/single/{AnimalID}
        [HttpGet("farms/{id:int}/animals/{animalType}/single/{AnimalID:int}")]
        public ActionResult<IEnumerable<string>> GetMedia(int id, string animalType, int AnimalID)
        {
            string mainDictory = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", "media");
            string ID = id.ToString();
            string AiD = AnimalID.ToString();

            string farmDictiory = Path.Combine(mainDictory, "farms", ID, "animals");
            string singleAnimals = Path.Combine(farmDictiory, animalType, "Ids", AiD);

            if (Directory.Exists(singleAnimals))

                return ProcessDirectory(singleAnimals);

            return new List<string>() { };
        }

        public List<string> ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            DirectoryInfo d = new DirectoryInfo(targetDirectory);
            FileInfo[] photoEntries = d.GetFiles();

            List<string> photosList = new List<string>() { };
            foreach (var file in photoEntries)
                photosList.Add(file.Name);

            return photosList;
        }
        #endregion

        #region Remove Dictories 
        // DELETE [User]: api/media/users/oiet-gdhd-hdyff
        [HttpDelete("users/{id}")]
        public ActionResult<string> DeleteUserFolder(string id)
        {
            string mainDictory = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", "media");
            string UserDictiory = Path.Combine(mainDictory, "users", id);


            if (Directory.Exists(UserDictiory))
            {
                Directory.Delete(UserDictiory, true);
                return $"Deleted User Folder";
            }
            else
                return NotFound();
        }

        // DELETE[Farm]: api/media/farms/
        [HttpDelete("farms/{id:int}")]
        public ActionResult<string> DeleteFarmFolder(int id)
        {
            string mainDictory = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", "media");
            string ID = id.ToString();

            string farmDictiory = Path.Combine(mainDictory, "farms", ID);

            if (Directory.Exists(farmDictiory))
            {
                Directory.Delete(farmDictiory, true);
                return $"Deleted Farm Folder";
            }
            else
                return NotFound();
        }

        //DELETE[Animal]: api/media/farms/{id}/animals/{animalType}/single/{AnimalID}
        [HttpDelete("farms/{id:int}/animals/{animalType}/single/{AnimalID:int}")]
        public ActionResult<string> DeleteAnimalFarmFolder(int id, string animalType, int AnimalID)
        {
            string mainDictory = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", "media");
            string ID = id.ToString();
            string AiD = AnimalID.ToString();

            string farmDictiory = Path.Combine(mainDictory, "farms", ID, "animals");
            string singleAnimals = Path.Combine(farmDictiory, animalType, "Ids", AiD);

            if (Directory.Exists(singleAnimals))
            {
                Directory.Delete(singleAnimals, true);
                return $"Deleted {animalType} Folder";
            }
            else
                return NotFound();
        }

        #endregion

        #region Delete Individual Photos
        // DELETE [User]: api/media/user/oiet-gdhd-hdyff
        [HttpDelete("user/{id}/{photoName}")]
        public ActionResult<string> DeleteUserPhotos(string id, string photoName)
        {
            string mainDictory = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", "media");
            string UserDictiory = Path.Combine(mainDictory, "users", id, photoName);

            try
            {
                System.IO.File.Delete(UserDictiory);
                return $"Deleted {photoName}";
            }
            catch (IOException e)
            {
                return NotFound(e);
            }
        }

        // DELETE [Farm]: api/media/farms/{id}/farm
        [HttpDelete("farms/{id:int}/farm/{photoName}")]
        public ActionResult<string> DeleteFarmPhotos(int id, string photoName)
        {
            string mainDictory = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", "media", "farms");
            string ID = id.ToString();

            string farmDictiory = Path.Combine(mainDictory, ID, "Farm", photoName);

            try
            {
                System.IO.File.Delete(farmDictiory);
                return $"Deleted {photoName}";
            }
            catch (IOException e)
            {
                return NotFound(e);
            }
        }

        // DELETE [Animal Groups]: api/media/farms/{id}/animals/{animalType}/many
        [HttpDelete("farms/{id}/animals/{animalType}/many/{photoName}")]
        public ActionResult<string> GroupAnimalPhotos(int id, string animalType, string photoName)
        {
            string mainDictory = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", "media", "farms");
            string ID = id.ToString();

            string farmDictiory = Path.Combine(mainDictory, ID, "animals", animalType);
            string manyAnimals = Path.Combine(farmDictiory, "kraal", photoName);

            try
            {
                System.IO.File.Delete(manyAnimals);
                return $"Deleted {photoName}";
            }
            catch (IOException e)
            {
                return NotFound(e);
            }
        }

        // DELETE [Single Animals]: api/media/farms/{id}/animals/{animalType}/single/{AnimalID}
        [HttpDelete("farms/{id:int}/animals/{animalType}/single/{AnimalID:int}/{photoName}")]
        public ActionResult<string> SingleAnimalPhotos(int id, string animalType, int AnimalID, string photoName)
        {
            string mainDictory = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot", "media", "farms");
            string ID = id.ToString();
            string AiD = AnimalID.ToString();

            string farmDictiory = Path.Combine(mainDictory, ID, "animals", animalType);
            string singleAnimals = Path.Combine(farmDictiory, "Ids", AiD, photoName);

            try
            {
                System.IO.File.Delete(singleAnimals);
                return $"Deleted {photoName}";
            }
            catch (IOException e)
            {
                return NotFound(e);
            }
        }
        #endregion
    }
}
