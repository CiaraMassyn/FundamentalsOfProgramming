using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Services;
using Services.Interfaces;

namespace Services.Interfaces
{
    public interface IReverseSentenceService
    {
        string GenerateReverseString(string sentence);
    }
}
