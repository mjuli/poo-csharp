using System;

namespace Application
{
	static class Texto
	{
		public static int ContarPalavras(string s){
			int result = 1;
			for (int i = 0; i < s.Length; i++) 
				if (s [i] == ' ') result ++;
			return result;
		}
	}
}

