using Microsoft.AspNetCore.DataProtection;

namespace H4SoftwareTest.Codes
{
    public class EncryptionHandler
    {
        private readonly IDataProtector _dataProtector;
        public EncryptionHandler(IDataProtectionProvider dataProtector)
        {
            _dataProtector = dataProtector.CreateProtector("NielsErMegaSej");
        }

        #region Symmetric Encryption
        public string EncryptSymmetric(string txtToEncrypt) => _dataProtector.Protect(txtToEncrypt);

        public string DecryptSymmetric(string txtToDecrypt) => _dataProtector.Unprotect(txtToDecrypt);
        #endregion

        #region Asymmetric Encryption

        #endregion
    }
}
