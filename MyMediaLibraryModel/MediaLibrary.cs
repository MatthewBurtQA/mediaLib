using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using MyMediaLibraryModel;
using System.Linq;



namespace MyMediaLibraryModel
{
	
	public class MediaLibrary
	{
		private string libName;
		private MediaItem meditem;
		private List<MediaItem> medias = new List<MediaItem>();
		
		public void addToLibrary(MediaItem media)
		{
			medias.Add(media); // append media to the end of the media list. 
		}

		

		public void accessElementAt (int acArg)
		{

		    medias.ElementAt(acArg).getTitle();
			Console.WriteLine("The title at " + acArg + " is " + medias.ElementAt(acArg).getTitle() +
				", And the age rating of this feature flick is: " + medias.ElementAt(acArg).getAgeRating());
		}

		public int mediaLibCount()
		{
			return medias.Count;

		}

	
	}
}
