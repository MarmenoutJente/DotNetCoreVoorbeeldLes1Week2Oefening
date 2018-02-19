using System;

namespace DotNetCoreVoorbeeldLes1Week2Oefening.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}