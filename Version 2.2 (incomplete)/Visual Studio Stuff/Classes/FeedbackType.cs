﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherWithGuna.Classes
{
    internal enum FeedbackType
    {
        EncryptSuccess, DecryptSuccess, EncryptKeyNotMatch, DecryptFail, InvalidKey, InvalidDecrypt
    }
}
