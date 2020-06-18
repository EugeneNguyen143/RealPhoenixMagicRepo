using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiantSchool.Models
{
	public class Attendance
	{
        public Course Course { get; set; }

        [Key]
        [Column(Order = 1)]
        public int CourseId { get; set; }

        public ApplicationUser Attendee { get; set; }

        [Key]
        [Column(Order = 2)]
        public string AttendeeId { get; set; }
        public string FollowerId { get; internal set; }
        public string FolloweeId { get; internal set; }

    }
}