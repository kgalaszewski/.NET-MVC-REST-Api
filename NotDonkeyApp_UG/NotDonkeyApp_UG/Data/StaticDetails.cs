using NotDonkeyApp_UG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotDonkeyApp_UG.Data
{
    public static class StaticDetails
    {
        /// <summary>
        /// Currently logged user info
        /// </summary>
        public static int CurrentUserId { get; set; }

        /// <summary>
        /// AvatarUrl + AnimalType from AnimalNotDonkeyModel == path to img
        /// </summary>
        public static readonly string AvatarUrl = "";

        /// <summary>
        /// List will be edited after you like some animal
        /// </summary>
        public static List<AnimalNotDonkey> DonkeysAvailableToLike = new List<AnimalNotDonkey>();
    }
}
