using System;

#pragma warning disable S2368

namespace LookingForArrayElements
{
    public static class DecimalCounter
    {
        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[] arrayToSearch, decimal[][] ranges)
        {
            // #5. Implement the method using "do..while" statements.
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges is null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            foreach (decimal[] row in ranges)
            {
                if (row is null)
                {
                    throw new ArgumentNullException(nameof(ranges));
                }
            }

            for (int x = 0; x < ranges.Length; x++)
            {
                if (ranges[x].Length > 2)
                {
                    throw new ArgumentException("Method throws ArgumentException in case the length of one of the ranges is less or greater than 2.");
                }
            }

            if (arrayToSearch == Array.Empty<decimal>() || ranges == Array.Empty<decimal[]>())
            {
                return 0;
            }

            int cnt = 0;
            int i = 0;
            do
            {
                int row = 0;
                do
                {
                    if (ranges[row] == Array.Empty<decimal>())
                    {
                        return cnt;
                    }

                    if (arrayToSearch[i] >= ranges[row][0] && arrayToSearch[i] <= ranges[row][1])
                    {
                        cnt++;
                        break;
                    }
                }
                while (row++ < ranges.Length - 1);
            }
            while (i++ < arrayToSearch.Length - 1);
            return cnt;
        }

        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[] arrayToSearch, decimal[][] ranges, int startIndex, int count)
        {
            // #6. Implement the method using "for" statement.
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges is null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            foreach (decimal[] row in ranges)
            {
                if (row is null)
                {
                    throw new ArgumentNullException(nameof(ranges));
                }
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i].Length > 2)
                {
                    throw new ArgumentException("Method throws ArgumentException in case the length of one of the ranges is less or greater than 2.");
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
            for (int i = startIndex; i < startIndex + count; i++)
            {
                for (int j = 0; j < ranges.Length; j++)
                {
                    if (arrayToSearch[i] >= ranges[j][0] && arrayToSearch[i] <= ranges[j][1])
                    {
                        cnt++;
                        break;
                    }
                }
            }

            return cnt;
        }
    }
}
