using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastenTerminal
{
	public static class Common
	{

		public static void PlaySound(String sound)
		{
			try
			{
				if (sound != null)
				{
					System.Media.SoundPlayer player = new System.Media.SoundPlayer(sound);
					player.Play();
				}
				else
				{
					//Log.SendErrorLog("Sound parameter is null.");
				}
			}
			catch (Exception e)
			{
				//Log.SendErrorLog("Sound playing has been failed. " + e.Message);
				Console.WriteLine("Sound playing has been failed. " + e.Message);
			}

		}




	}
}
