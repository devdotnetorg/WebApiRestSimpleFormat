using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Drawing;
using System.IO;

namespace WebApiRestSimpleFormat.Models
{
    public class FormatBoxModel
    {
        public string output_format { get; set; }
        public string image_file { get; set; }
        public string xml_file { get; set; }
    }

}

