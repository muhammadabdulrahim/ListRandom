using System;
using System.Collections.Generic;

namespace ListRandom
{
	public static class ListRandomExtensionMethods
	{
		private static Random rng = new Random();

		/// <summary>
		/// Return a random entry from within the list
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <return></returns>
		public static T RandomValue<T>(this IList<T> list)
		{
			return list[rng.Next(list.Count)];
		}

		/// <summary>
		/// Shuffle a given list using the Fisher-Yates algorithm
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		public static void Shuffle<T>(this IList<T> list)
		{
			int n = list.Count;
			while (n>1)
			{
				n--;
				int k = rng.Next(n+1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}

	}
}
