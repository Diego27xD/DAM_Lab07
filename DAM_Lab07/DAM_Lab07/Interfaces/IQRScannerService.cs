using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAM_Lab07.Interfaces
{
    public interface IQRScannerService
    {
        Task<String> ReadQrScanner();
    }
}
