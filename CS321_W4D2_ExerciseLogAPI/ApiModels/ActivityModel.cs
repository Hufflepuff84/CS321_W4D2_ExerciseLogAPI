﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CS321_W4D2_ExerciseLogAPI.ApiModels
{
    public class ActivityModel
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int ActivityTypeId { get; set; }
        //  Make ActivityType a string property that will contain the name of the activity type (update the
        //mapping code)
        public string ActivityType { get; set; }

        [Required]
        public double Duration { get; set; }
        public double Distance { get; set; }

        [Required]
        public int UserId { get; set; }
        //  Make User a string property that will contain the User's name (updating the mapping code)
        public string User { get; set; }

        public string Notes { get; set; }
    }
}