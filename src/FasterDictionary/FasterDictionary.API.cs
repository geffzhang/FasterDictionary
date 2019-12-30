﻿using FASTER.core;
using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading.Tasks;

namespace FasterDictionary
{
    public enum MemorySizes
    {
        MB16 = 27,
        MB32 = MB16 + 1,
        MB64 = MB32 + 1,
        MB128 = MB64 + 1,
        MB256 = MB128 + 1,
        MB512 = MB256 + 1,
        MB1024 = MB512 + 1,
        GB1 = MB1024,
        GB2 = GB1 + 1
    }

    

    public partial class FasterDictionary<TKey, TValue>
    {
       
        public interface IKeyComparer
        {

        }

        
        public Task TryGet(TKey key)
        {
            throw new NotImplementedException();
        }

        public Task<TValue> Upsert(TKey key, TValue value)
        {
            return Enqueue(new Job(key, value, JobTypes.Upsert));
        }


    }
}