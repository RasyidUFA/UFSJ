using System;
using System.IO;
using System.Security.Cryptography;

namespace UFSJ.Sharp.Hash
{
    class Adler32 : HashAlgorithm
    {
        public const uint AdlerBase = 0xfff1;
        public const uint AdlerStart = 1;
        public const uint AdlerBuff = 0x400;
        public uint unAdlerCheckSum = 1u;
        public uint _Adler32Value;
         bool _hashCoreCalled;
        bool _hashFinalCalled;
        public override byte[] Hash { get { return  BitConverter.GetBytes(_Adler32Value); } }

        public Adler32()
        {
            this.InitializeVariables();
        }

        public bool MakeForBuff(byte[] bytesBuff)
        {
            bool result;
            if (object.Equals(bytesBuff, null)) {
                _Adler32Value = 0;
                result = false;
            } else {
                int length = bytesBuff.GetLength(0);
                if (length == 0) {
                    _Adler32Value = 0;
                    result = false;
                } else {
                    HashCore(bytesBuff, 0, bytesBuff.Length);
                    result = true;
                }
            }
            return result;
        }

        public bool MakeForFile(string sPath)
        {
            bool result;
            try {
                if (!File.Exists(sPath)) {
                    this._Adler32Value = 0u;
                    result = false;
                    return result;
                }
                using (var fileStream = new FileStream(sPath, FileMode.Open, FileAccess.Read)) {
                    this._Adler32Value = 1u;
                    var array = new byte[1024];
                    uint num = 0u;
                    while ((ulong)num < (ulong)fileStream.Length) {
                        uint num2 = num % 1024u;
                        array[(int)(num2)] = (byte)fileStream.ReadByte();
                        if (num2 == 1023u || (ulong)num == (ulong)(fileStream.Length - 1L)) {
                            if (!this.MakeForBuff(array)) {
                                this._Adler32Value = 0u;
                                result = false;
                                return result;
                            }
                        }
                        num += 1;
                    }
                }
            } catch {
                this._Adler32Value = 0u;
                result = false;
                return result;
            }
            result = true;
            return result;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            if (null == array) throw new ArgumentNullException("array");

            if (_hashFinalCalled) throw new CryptographicException("Hash not valid for use in specified state.");

            _hashCoreCalled = true;
            uint num = unAdlerCheckSum & 0xffff;
            uint num2 = unAdlerCheckSum >> 16 & 0xffff;
            for (int i = ibStart ; i < cbSize ; i++) {
                num = (num + (uint)array[i]) % 0xfff1;
                num2 = (num + num2) % 0xfff1;
            }
            _Adler32Value = (num2 << 16) + num;

        }

        protected override byte[] HashFinal()
        {   
            _hashFinalCalled = true;
            return (Hash);
        }

      private void InitializeVariables()
        {
            this._Adler32Value = 0xffffffff;
			this._hashCoreCalled &= !_hashCoreCalled;
            this._hashFinalCalled = false;
        }

        public override void Initialize()
        {
            this.InitializeVariables();
        }

        #region Override & Operator

        public override bool Equals(object obj)
        {
            bool result;
            if (obj != null) {
                if (base.GetType() == obj.GetType()) {
                    var adler = (Adler32)obj;
                    result = (this.Hash == adler.Hash);
                } else result = false;
            } else result = false;
            return result;
        }

        public static bool operator ==(Adler32 objA, Adler32 objB)
        {
            return (object.Equals(objA, null) && object.Equals(objB, null)) || (!object.Equals(objA, null) && !object.Equals(objB, null) && objA.Equals(objB));
        }

        public static bool operator !=(Adler32 objA, Adler32 objB)
        {
            return !(objA == objB);
        }

        public override int GetHashCode()
        {
            return Hash.GetHashCode();
        }

        public override string ToString()
        {
            return Hash != null ? this.Hash.ToString() : "Unknown";
        }

        #endregion
      
        
    }
}
