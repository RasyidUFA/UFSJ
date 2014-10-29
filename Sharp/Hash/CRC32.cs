using System;

namespace UFSJ.Sharp.Hash
{
    /// <summary>
    /// Calculates a 32bit Cyclic Redundancy Checksum (CRC) using the
    /// same polynomial used by Zip.
    /// </summary>
    public class CRC32
    {
        private UInt32[] crc32Table;
        private const int BUFFER_SIZE = 1024;

        /// <summary>
        /// Returns the CRC32 for the specified stream.
        /// </summary>
        /// <param name="stream">The stream to calculate the CRC32 for</param>
        /// <returns>An unsigned integer containing the CRC32 calculation</returns>
        public UInt32 GetCrc32(System.IO.Stream stream)
        {
            unchecked {
                UInt32 crc32Result;
                crc32Result = 0xFFFFFFFF;
                var buffer = new byte[BUFFER_SIZE];
                int readSize = BUFFER_SIZE;

                int count = stream.Read(buffer, 0, readSize);
                while (count > 0) {
                    for (int i = 0 ; i < count ; i++) {
                        crc32Result = ((crc32Result) >> 8) ^ crc32Table[(buffer[i]) ^ ((crc32Result) & 0x000000FF)];
                    }
                    count = stream.Read(buffer, 0, readSize);
                }

                return ~crc32Result;
            }
        }

        /// <summary>
        /// Construct an instance of the CRC32 class, pre-initialising the table
        /// for speed of lookup.
        /// </summary>
        public CRC32()
        {
            unchecked {
                // This is the official polynomial used by CRC32 in PKZip.
                // Often the polynomial is shown reversed as 0x04C11DB7.
				const UInt32 dwPolynomial = 0xEDB88320;
                UInt32 i, j;

                crc32Table = new UInt32[256];

                UInt32 dwCrc;
                for (i = 0 ; i < 256 ; i++) {
                    dwCrc = i;
                    for (j = 8 ; j > 0 ; j--) {
                        if ((dwCrc & 1) == 1) {
                            dwCrc = (dwCrc >> 1) ^ dwPolynomial;
                        } else {
                            dwCrc >>= 1;
                        }
                    }
                    crc32Table[i] = dwCrc;
                }
            }
        }
    }
   
    //class CRC32 : HashAlgorithm
    //{
    //    static readonly uint[] _crc32Table;
    //    uint _crc32Value;
    //    bool _hashCoreCalled;
    //    bool _hashFinalCalled;

    //    public override byte[] Hash
    //    {
    //        get
    //        {
    //            if (!_hashCoreCalled) {
    //                throw new NullReferenceException();
    //            }
    //            if (!_hashFinalCalled) {
    //                throw new CryptographicException("Hash must be finalized before the hash value is retrieved.");
    //            }
    //            foreach (var item in this._crc32Value.ToString()) {
                    
    //            }
    //            byte[] bytes = BitConverter.GetBytes();
    //            Array.Reverse(bytes);
    //            return bytes;
    //        }
    //    }
    //    public override int HashSize
    //    {
    //        get
    //        {
    //            return 32;
    //        }
    //    }
    //    static CRC32()
    //    {
    //        CRC32._crc32Table = new uint[256];
    //        for (uint num = 0u ; num < 256u ; num += 1u) {
    //            uint num2 = num;
    //            for (int i = 0 ; i < 8 ; i++) {
    //                if (0u != (num2 & 1u)) {
    //                    num2 = (0xedb88320 ^ num2 >> 1);
    //                } else {
    //                    num2 >>= 1;
    //                }
    //            }
    //            CRC32._crc32Table[(int)(num)] = num2;
    //        }
    //    }

    //    public CRC32()
    //    {
    //        this.InitializeVariables();
    //    }
    
    //    public override void Initialize()
    //    {
    //        this.InitializeVariables();
    //    }
      
    //    private void InitializeVariables()
    //    {
    //        this._crc32Value = 0xffffffff;
    //        this._hashCoreCalled = false;
    //        this._hashFinalCalled = false;
    //    }
    //    protected override void HashCore(byte[] array, int ibStart, int cbSize)
    //    {
    //        if (null == array) {
    //            throw new ArgumentNullException("array");
    //        }
    //        if (_hashFinalCalled) {
    //            throw new CryptographicException("Hash not valid for use in specified state.");
    //        }
    //        _hashCoreCalled = true;
    //        for (int i = ibStart ; i < ibStart + cbSize ; i++) {
    //            uint num = (_crc32Value ^ (uint)array[i]) & 0xff;
    //            _crc32Value = (CRC32._crc32Table[(int)(num)] ^ (_crc32Value >> 8 & 0xffffff));
    //        }
    //    }
    //    protected override byte[] HashFinal()
    //    {
    //        _hashFinalCalled = true;
    //        return Hash;
    //    }
    //    public void CalcHashBuffer(byte[] array, int ibStart, int cbSize)
    //    {
    //        HashCore(array, ibStart, cbSize);
    //    }
    //    public byte[] CalcFinal()
    //    {
    //        return this.HashFinal();
    //    }
    //    public string CalcHashFinal()
    //    {
    //        return BitConverter.ToString(this.HashFinal(), 0).Replace("-", "");
    //    }
    //}
}
