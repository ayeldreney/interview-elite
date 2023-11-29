using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inteview_task.DAL.models
{
	
	public class item
	{
		public int ID { get; set; }
		public string Item_name { get; set; }
		public int Quntity { get; set; }
		public int Unit_price { get; set; }

		public int Totat { get; set; }
	}
}