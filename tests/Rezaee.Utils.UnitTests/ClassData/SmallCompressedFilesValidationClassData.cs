﻿using System.Collections;
using System.Collections.Generic;

namespace Rezaee.Utils.UnitTests.ClassData
{
    public class SmallCompressedFilesValidationClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // Smallest possible syntactically valid files of different types 
            // see: https://github.com/mathiasbynens/small

            yield return new object[]
            {
                new byte[]
                {
                    0x37, 0x7a, 0xbc, 0xaf, 0x27, 0x1c, 0x00, 0x04, 0x8d, 0x9b, 0xd5, 0x0f, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                },
                "7z.7z"
            };

            yield return new object[]
            {
                new byte[]
                {
                    0x42, 0x5a, 0x68, 0x39, 0x17, 0x72, 0x45, 0x38, 0x50, 0x90, 0x00, 0x00, 0x00, 0x00
                },
                "bzip2.bz2"
            };

            yield return new object[]
            {
                new byte[]
                {
                    0x1f, 0x8b, 0x08, 0x08, 0xae, 0x86, 0xe1, 0x5b, 0x02, 0x03, 0x6e, 0x00, 0x03, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                },
                "gzip-name.gz"
            };

            yield return new object[]
            {
                new byte[]
                {
                    0x50, 0x4b, 0x03, 0x04, 0x0a, 0x00, 0x00, 0x08, 0x00, 0x00, 0x02, 0x68, 0x48, 0x58, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x09, 0x00, 0x04, 0x00, 0x4d, 0x45,
                    0x54, 0x41, 0x2d, 0x49, 0x4e, 0x46, 0x2f, 0xfe, 0xca, 0x00, 0x00, 0x50, 0x4b, 0x03, 0x04, 0x0a,
                    0x00, 0x00, 0x08, 0x00, 0x00, 0xb8, 0x5d, 0x48, 0x58, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x74, 0x65, 0x73, 0x74, 0x2f, 0x50, 0x4b,
                    0x01, 0x02, 0x0a, 0x00, 0x0a, 0x00, 0x00, 0x08, 0x00, 0x00, 0x02, 0x68, 0x48, 0x58, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x09, 0x00, 0x04, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4d, 0x45, 0x54, 0x41,
                    0x2d, 0x49, 0x4e, 0x46, 0x2f, 0xfe, 0xca, 0x00, 0x00, 0x50, 0x4b, 0x01, 0x02, 0x0a, 0x00, 0x0a,
                    0x00, 0x00, 0x08, 0x00, 0x00, 0xb8, 0x5d, 0x48, 0x58, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x2b, 0x00, 0x00, 0x00, 0x74, 0x65, 0x73, 0x74, 0x2f, 0x50, 0x4b, 0x05, 0x06,
                    0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0x02, 0x00, 0x6e, 0x00, 0x00, 0x00, 0x4e, 0x00, 0x00, 0x00,
                    0x00, 0x00
                },
                "jar.jar"
            };

            yield return new object[]
            {
                new byte[]
                {
                    0x50, 0x4b, 0x03, 0x04, 0x0a, 0x00, 0x00, 0x08, 0x00, 0x00, 0xad, 0x60, 0x48, 0x58, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x09, 0x00, 0x04, 0x00, 0x4d, 0x45,
                    0x54, 0x41, 0x2d, 0x49, 0x4e, 0x46, 0x2f, 0xfe, 0xca, 0x00, 0x00, 0x50, 0x4b, 0x03, 0x04, 0x0a,
                    0x00, 0x00, 0x08, 0x00, 0x00, 0xb8, 0x5d, 0x48, 0x58, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x74, 0x65, 0x73, 0x74, 0x2f, 0x50, 0x4b,
                    0x01, 0x02, 0x0a, 0x00, 0x0a, 0x00, 0x00, 0x08, 0x00, 0x00, 0xad, 0x60, 0x48, 0x58, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x09, 0x00, 0x04, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4d, 0x45, 0x54, 0x41,
                    0x2d, 0x49, 0x4e, 0x46, 0x2f, 0xfe, 0xca, 0x00, 0x00, 0x50, 0x4b, 0x01, 0x02, 0x0a, 0x00, 0x0a,
                    0x00, 0x00, 0x08, 0x00, 0x00, 0xb8, 0x5d, 0x48, 0x58, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x2b, 0x00, 0x00, 0x00, 0x74, 0x65, 0x73, 0x74, 0x2f, 0x50, 0x4b, 0x05, 0x06,
                    0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0x02, 0x00, 0x6e, 0x00, 0x00, 0x00, 0x4e, 0x00, 0x00, 0x00,
                    0x00, 0x00
                },
                "jar-msopenjdk.jar"
            };

            yield return new object[]
            {
                new byte[]
                {
                    0x52, 0x61, 0x72, 0x21, 0x1a, 0x07, 0x00, 0xcf, 0x90, 0x73, 0x00, 0x00, 0x0d, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x3f, 0x1e, 0x74, 0x00, 0x80, 0x21, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x07, 0x63, 0x66, 0x4d, 0x0f, 0x33, 0x01, 0x00,
                    0x20, 0x00, 0x00, 0x00, 0x6e
                },
                "rar4.rar"
            };

            yield return new object[]
            {
                new byte[]
                {
                    0x52, 0x61, 0x72, 0x21, 0x1a, 0x07, 0x01, 0x00, 0x33, 0x92, 0xb5, 0xe5, 0x0a, 0x01, 0x05, 0x06,
                    0x00, 0x05, 0x01, 0x01, 0x80, 0x80, 0x00, 0xed, 0xb6, 0x9e, 0x60, 0x1d, 0x02, 0x03, 0x0b, 0x80,
                    0x00, 0x04, 0x80, 0x00, 0x20, 0x00, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x01, 0x6e, 0x0a, 0x03,
                    0x02, 0x62, 0x5e, 0x7f, 0xe2, 0xca, 0x75, 0xd4, 0x01, 0x1d, 0x77, 0x56, 0x51, 0x03, 0x05, 0x04,
                    0x00
                },
                "rar5.rar"
            };

            yield return new object[]
            {
                new byte[]
                {
                    0x52, 0x45, 0x7e, 0x5e, 0x07, 0x00, 0xc0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x16, 0x00, 0xa0, 0xa9, 0x84, 0x4d, 0x20, 0x00, 0x02, 0x01, 0x05, 0x4e
                },
                "rar14.rar"
            };

            yield return new object[]
            {
                new byte[]
                {
                    0x6e, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x30, 0x30, 0x30, 0x30, 0x36, 0x34, 0x34, 0x00, 0x31, 0x31, 0x33, 0x37,
                    0x33, 0x36, 0x32, 0x00, 0x30, 0x32, 0x35, 0x37, 0x35, 0x32, 0x33, 0x00, 0x30, 0x30, 0x30, 0x30,
                    0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x00, 0x31, 0x33, 0x33, 0x37, 0x30, 0x33, 0x30, 0x33,
                    0x32, 0x35, 0x36, 0x00, 0x30, 0x31, 0x32, 0x32, 0x32, 0x32, 0x00, 0x20, 0x30, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x75, 0x73, 0x74, 0x61, 0x72, 0x20, 0x20, 0x00, 0x63, 0x6f, 0x72, 0x6b, 0x61, 0x6d, 0x69,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x70, 0x72, 0x69, 0x6d, 0x61, 0x72, 0x79,
                    0x67, 0x72, 0x6f, 0x75, 0x70, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                },
                "tar.tar"
            };

            yield return new object[]
            {
                new byte[]
                {
                    0x50, 0x4b, 0x05, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                },
                "zip.zip"
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
