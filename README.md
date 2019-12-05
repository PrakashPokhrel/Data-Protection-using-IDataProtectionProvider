# Data-Protection-using-IDataProtectionProvider
This Process is easier for developers to use solid Cryptographic algorithm to make safe their data in the case you need to encrypt/decrypt your data frequently.  With this,  If you need to encrypt data, simply pass the data into the protect method. If you need to access the data again, pass the encrypted data into the Unprotect method, and it will be converted back into plaintext.    By default, it uses 256-bit AES encryption to protect data, which is one of the best choices for an algorithm and It hides all the background task from the developer. Because When you encrypt data, key management becomes a concern.
find more: 
https://www.ttmind.com/TechPost/aspnet-core-data-protection-using-idataprotectionprovider-wi
