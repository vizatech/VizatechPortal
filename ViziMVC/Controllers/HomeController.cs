using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViziMVC.Models.UsersPagePartitions;
namespace ViziMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DeviceCreate()
        {
            return View();
        }
        public ActionResult Feed()
        {
            return View();
        }
        public ActionResult Messages()
        {
            return View();
        }
        public ActionResult SampleDialog()
        {
            return View();
        }
        public ActionResult DataSources()
        {
            return View();
        }
        [HttpGet]
        public ActionResult MainInformation()
        {

            MainInformation UserMainData = new MainInformation();

            UserMainData.UserName = "Nazar";
            UserMainData.UserSername = "Syngaivskyi";
            UserMainData.UserJobTitle = "CoreDev";
            UserMainData.UserPhotoURL = "assets/avatar.jpg";

            return View("~/Views/Shared/UserPage/MainInformation.cshtml", UserMainData);
        }
        [HttpGet]
        public ActionResult RatingBar()
        {
            RatingBar UserRatingBar = new RatingBar();
            UserRatingBar.UserRating = "60";
            return View("~/Views/Shared/UserPage/RatingBar.cshtml", UserRatingBar);
        }
        [HttpGet]
        public ActionResult UserPlusInfo()
        {
            UserPlus UserPlusInfo = new UserPlus();
            UserPlusInfo.Login = "isorl";
            UserPlusInfo.RegId = "f29be1af-e59cac9376df";
            UserPlusInfo.RegData = "27-02-2017";
            UserPlusInfo.PhoneNumber = "+380996000170";
            UserPlusInfo.Skype = "iso.rl";
            UserPlusInfo.Email = "nazar.syngaivskyi@gmail.com";
            UserPlusInfo.PersonalSite = "vizatech.com";
            UserPlusInfo.Country = "Ukraine";
            UserPlusInfo.LinkToFacebook = "facebook.com/nazar.syngaivskyi";
            return View("~/Views/Shared/UserPage/UserPlusInfo.cshtml", UserPlusInfo);
        }
        [HttpGet]
        public ActionResult SubscriptionOwnersList()
        {
            List<Owner> Owners = new List<Owner>();

            Owners.Add(new Owner { OwnerPictureUrl = "assets/avatars/020.png", OwnerId = "", ShortPopUp = "", PersonalFilters = " iot sql mob web" });
            Owners.Add(new Owner { OwnerPictureUrl = "assets/avatars/021.png", OwnerId = "", ShortPopUp = "", PersonalFilters = " iot " });
            Owners.Add(new Owner { OwnerPictureUrl = "assets/avatars/022.png", OwnerId = "", ShortPopUp = "", PersonalFilters = " mob web" });
            Owners.Add(new Owner { OwnerPictureUrl = "assets/avatars/023.png", OwnerId = "", ShortPopUp = "", PersonalFilters = " iot sql web" });
            Owners.Add(new Owner { OwnerPictureUrl = "assets/avatars/024.png", OwnerId = "", ShortPopUp = "", PersonalFilters = " web" });
            Owners.Add(new Owner { OwnerPictureUrl = "assets/avatars/025.png", OwnerId = "", ShortPopUp = "", PersonalFilters = " web" });
            Owners.Add(new Owner { OwnerPictureUrl = "assets/avatars/026.png", OwnerId = "", ShortPopUp = "", PersonalFilters = " iot mob web" });
            Owners.Add(new Owner { OwnerPictureUrl = "assets/avatars/027.png", OwnerId = "", ShortPopUp = "", PersonalFilters = " iot sql mob web" });
            Owners.Add(new Owner { OwnerPictureUrl = "assets/avatars/028.png", OwnerId = "", ShortPopUp = "", PersonalFilters = " iot web" });
            Owners.Add(new Owner { OwnerPictureUrl = "assets/avatars/029.png", OwnerId = "", ShortPopUp = "", PersonalFilters = " iot sql mob web" });

            return View("~/Views/Shared/UserPage/SubscriptionOwnersList.cshtml", Owners);
        }
        [HttpGet]
        public ActionResult FriendsList()
        {
            List<Friend> Friends = new List<Friend>();

            Friends.Add(new Friend { PictureUrl = "assets/avatars/001.png", Id = "", ShortPopUp = "", PersonalFilters = " iot sql mob web" });
            Friends.Add(new Friend { PictureUrl = "assets/avatars/002.png", Id = "", ShortPopUp = "", PersonalFilters = " iot " });
            Friends.Add(new Friend { PictureUrl = "assets/avatars/003.png", Id = "", ShortPopUp = "", PersonalFilters = " mob web" });
            Friends.Add(new Friend { PictureUrl = "assets/avatars/004.png", Id = "", ShortPopUp = "", PersonalFilters = " iot sql web" });
            Friends.Add(new Friend { PictureUrl = "assets/avatars/005.png", Id = "", ShortPopUp = "", PersonalFilters = " web" });
            Friends.Add(new Friend { PictureUrl = "assets/avatars/006.png", Id = "", ShortPopUp = "", PersonalFilters = " web" });
            Friends.Add(new Friend { PictureUrl = "assets/avatars/007.png", Id = "", ShortPopUp = "", PersonalFilters = " iot mob web" });
            Friends.Add(new Friend { PictureUrl = "assets/avatars/008.png", Id = "", ShortPopUp = "", PersonalFilters = " iot sql mob web" });
            Friends.Add(new Friend { PictureUrl = "assets/avatars/009.png", Id = "", ShortPopUp = "", PersonalFilters = " iot web" });
            Friends.Add(new Friend { PictureUrl = "assets/avatars/010.png", Id = "", ShortPopUp = "", PersonalFilters = " iot sql mob web" });

            return View("~/Views/Shared/UserPage/FriendsList.cshtml", Friends);
        }
        
        [HttpGet]
        public ActionResult DeviceList()
        {
            List<DevItem> Devices = new List<DevItem>();

            Devices.Add(new DevItem { DeviceOwnerName = "", DeviceID = "", DeviceIconURL = "assets/devices/031.png", DeviceOwnerIconURL = "", DeviceView = "", DeviceFilters = " iot web" });
            Devices.Add(new DevItem { DeviceOwnerName = "", DeviceID = "", DeviceIconURL = "assets/devices/032.png", DeviceOwnerIconURL = "", DeviceView = "", DeviceFilters = " iot" });
            Devices.Add(new DevItem { DeviceOwnerName = "", DeviceID = "", DeviceIconURL = "assets/devices/033.png", DeviceOwnerIconURL = "", DeviceView = "", DeviceFilters = " mob web" });
            Devices.Add(new DevItem { DeviceOwnerName = "", DeviceID = "", DeviceIconURL = "assets/devices/034.png", DeviceOwnerIconURL = "", DeviceView = "", DeviceFilters = " web" });
            Devices.Add(new DevItem { DeviceOwnerName = "", DeviceID = "", DeviceIconURL = "assets/devices/035.png", DeviceOwnerIconURL = "", DeviceView = "", DeviceFilters = " iot sql mob web" });
            Devices.Add(new DevItem { DeviceOwnerName = "", DeviceID = "", DeviceIconURL = "assets/devices/021.png", DeviceOwnerIconURL = "", DeviceView = "", DeviceFilters = " iot web" });
            Devices.Add(new DevItem { DeviceOwnerName = "", DeviceID = "", DeviceIconURL = "assets/devices/022.png", DeviceOwnerIconURL = "", DeviceView = "", DeviceFilters = " iot" });
            Devices.Add(new DevItem { DeviceOwnerName = "", DeviceID = "", DeviceIconURL = "assets/devices/023.png", DeviceOwnerIconURL = "", DeviceView = "", DeviceFilters = " mob web" });
            Devices.Add(new DevItem { DeviceOwnerName = "", DeviceID = "", DeviceIconURL = "assets/devices/024.png", DeviceOwnerIconURL = "", DeviceView = "", DeviceFilters = " web" });
            Devices.Add(new DevItem { DeviceOwnerName = "", DeviceID = "", DeviceIconURL = "assets/devices/025.png", DeviceOwnerIconURL = "", DeviceView = "", DeviceFilters = " iot sql mob web" });
            return View("~/Views/Shared/UserPage/DeviceList.cshtml", Devices);
        }
    }
}