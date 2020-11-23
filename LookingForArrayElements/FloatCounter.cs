using System;

namespace LookingForArrayElements
{
    public static class FloatCounter
    {
        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart is null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }

            if (rangeEnd is null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("Method throws ArgumentException in case an arrays of range starts and range ends contain different number of elements.");
            }

            for (int i = 0; i < rangeEnd.Length; i++)
            {
                if (rangeStart[i] > rangeEnd[i])
                {
                    throw new ArgumentException("Method throws ArgumentException in case the range start value is greater than the range end value.");
                }
            }

            // #3. Implement the method using "for" statement.
            int cnt = 0;
            for (int numberOfRanges = 0; numberOfRanges < rangeEnd.Length; numberOfRanges++)
            {
                for (int i = 0; i < arrayToSearch.Length; i++)
                {
                    if (arrayToSearch[i] >= rangeStart[numberOfRanges] && arrayToSearch[i] <= rangeEnd[numberOfRanges])
                    {
                        cnt++;
                    }
                }
            }

            return cnt;
        }

        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd, int startIndex, int count)
        {
            // #4. Implement the method using "do..while" statements.
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart is null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }

            if (rangeEnd is null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("Method throws ArgumentException in case an arrays of range starts and range ends contain different number of elements.");
            }

            for (int i = 0; i < rangeEnd.Length; i++)
            {
                if (rangeStart[i] > rangeEnd[i])
                {
                    throw new ArgumentException("Method throws ArgumentException in case the range start value is greater than the range end value.");
                }
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException($"Method throws ArgumentOutOfRangeException in case start index is negative.");
            }

            if (startIndex >= arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException($"Method throws ArgumentOutOfRangeException in case start index is greater than the length of an array to search.");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException($"Method throws ArgumentOutOfRangeException in case count is less than zero.");
            }

            if (startIndex + count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException($"Method throws ArgumentOutOfRangeException in case the number of elements to search is greater than the number of elements available in the array starting from the startIndex position.");
            }

            int cnt = 0;
            for (int numberOfRanges = 0; numberOfRanges < rangeEnd.Length; numberOfRanges++)
            {
                for (int i = startIndex; i < startIndex + count; i++)
                {
                    if (arrayToSearch[i] >= rangeStart[numberOfRanges] && arrayToSearch[i] <= rangeEnd[numberOfRanges])
                    {
                        cnt++;
                    }
                }
            }

            return cnt;
        }
    }
}
