using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Services.SectionSingleService.Common;

public record SectionSingleRequest(SectionTyp SectionTyp, string Description);
