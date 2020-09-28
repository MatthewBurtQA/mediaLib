using System;
using System.Collections.Generic;
using System.Text;
using MyMediaLibraryModel;
using Xunit;

namespace XUnitTests
{
	public class Check_med_Library
	{
		private List<MediaItem> medias = new List<MediaItem>();


		[Fact]
		public void addTest()
		{
			MediaItem meditem = new MediaItem();
			meditem.setTitle("Tetris");
			meditem.setAgeRating(240);
			medias.Add(meditem);

			Assert.Single(medias);
		}

	}
}
