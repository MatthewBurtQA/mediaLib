using System;
using System.Collections.Generic;
using System.Text;

namespace MyMediaLibraryModel
{
	public class MediaItem
	{
		String title;
		private String Title { get; set; }
		private int ageRating { get; set; }


		public void AddMediaItem(MediaItem mediaitem)
		{
			MediaItem media = new MediaItem { 
			Title="The Bungus Triology part 2",
			ageRating=254};

			throw new NotImplementedException();
			
		}

		public void setTitle(String title)
		{
			this.title = title;
		}

		public String getTitle(){

			return this.title;
		}
		public void setAgeRating(int ageRate)
		{
			this.ageRating = ageRate;

		}

		public int getAgeRating()
		{
			return this.ageRating;
		}
	}

}
