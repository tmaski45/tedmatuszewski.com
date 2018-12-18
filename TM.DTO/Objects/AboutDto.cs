﻿using System.Collections.Generic;
using System.Linq;

namespace TM.DTO.Objects
{
    public class AboutDto
    {
        public AboutDto(List<ContentDto> contents)
        {
            this.Work = contents.Where(c => c.Type == "WorkHistory").OrderBy(w => w.Order).ToList();
            this.Education = contents.Where(c => c.Type == "EducationHistory").OrderBy(w => w.Order).ToList();
            this.Skills = contents.Where(c => c.Type == "Skill").OrderByDescending(c => c.Year).ToList();
        }

        public List<ContentDto> Work { get; private set; }

        public List<ContentDto> Education { get; private set; }

        public List<ContentDto> Skills { get; private set; }
    }
}