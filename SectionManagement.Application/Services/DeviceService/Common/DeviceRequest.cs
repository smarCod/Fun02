using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Services.DeviceService.Common;

public record DeviceRequest(int DeviceId, string Name, int? SectionSingleId);
