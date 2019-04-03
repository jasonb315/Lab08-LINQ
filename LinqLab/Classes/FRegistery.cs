using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinqLab.Classes
{
    public class FRegistery<T> : IEnumerable
    {
        int count = 0;
        List<T> list = new List<T>();

        public void Add(T feature)
        {
            list.Add(feature);
            count++;
        }

        /// <summary>
        ///     Enumerated through list
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return list[i];
            }
        }

        // Magic. Don't Touch.
        // C# 1.0 support
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
