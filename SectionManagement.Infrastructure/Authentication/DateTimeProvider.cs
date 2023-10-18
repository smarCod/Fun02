using SectionManagement.Application.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Infrastructure.Authentication;

public class DataTimeProvider : IDataTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
