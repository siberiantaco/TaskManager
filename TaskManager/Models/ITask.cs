using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{ 
    interface ITask
    {      
        [Required]
        [Display(ResourceType = typeof(Resources.Resource), Name = "Name")]
        String Name { get; set; }

        [Required]
        [Display(ResourceType = typeof(Resources.Resource), Name = "Description")]
        String Description { get; set; }

        [Required]
        [Display(ResourceType = typeof(Resources.Resource), Name = "Executives")]
        String Executives { get; set; }

        [Required]
        [Display(ResourceType = typeof(Resources.Resource), Name = "Status")]
        int Status { get; set; }

        [Required]
        [Display(ResourceType = typeof(Resources.Resource), Name = "Laboriousness")]
        int Laboriousness { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(ResourceType = typeof(Resources.Resource), Name = "TaskTime")]
        TimeSpan TaskTime { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(ResourceType = typeof(Resources.Resource), Name = "RegDate")]
        DateTime RegDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(ResourceType = typeof(Resources.Resource), Name = "EndDate")]
        DateTime EndDate { get; set; }
    }
}
