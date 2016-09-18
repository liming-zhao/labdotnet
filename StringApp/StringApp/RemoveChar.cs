using System;

namespace StringApp
{
	public class RemoveChar
	{

	
		public static String removeChar (String str, String remove)
		{
			char[] s = str.ToCharArray ();
			char[] r = remove.ToCharArray ();
			bool[] flag = new bool[128];
			int len = r.Length;
			int src = 0 , dst = 0;

			for(int i =0; i < len; i++)
			{
				flag[r[i]] = true;
			}

			while (src < s.Length) {
				
				if(!flag[s [src]])
				{
					s [dst++] = s [src];
				}
				++src;

			}

			return new string (s, 0, dst);




		}
	}
}

