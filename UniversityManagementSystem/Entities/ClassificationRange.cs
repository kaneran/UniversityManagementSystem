﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Entities
{
    public class ClassificationRange
    {
        public double MinGrade { get; set; }
        public double MaxGrade { get; set; }
        public ClassificationRange(double minGrade, double maxGrade)
        {
            MinGrade = minGrade;
            MaxGrade = maxGrade;
        }
    }
}
