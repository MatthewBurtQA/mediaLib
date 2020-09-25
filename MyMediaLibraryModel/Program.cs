using System;
using System.Collections.Generic;
using MyMediaLibraryModel;

namespace MyMediaLibraryModel
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Initiating media library litanies, proceeding tech response psalms");
			MediaItem meditem = new MediaItem();
			meditem.setTitle("Tetris");
			meditem.setAgeRating(240);

			MediaItem mediaTwo = new MediaItem();
			mediaTwo.setTitle("Big Chungras Goes to New York");
			mediaTwo.setAgeRating(21);

			Console.WriteLine("way hay roll and go, the list is upcoming, its parts on the go...");
			MediaLibrary myLibrary = new MediaLibrary();

			myLibrary.addToLibrary(meditem);
			myLibrary.addToLibrary(mediaTwo);
			Console.WriteLine(myLibrary.mediaLibCount());
			myLibrary.accessElementAt(1);

			

		}
	}
}
