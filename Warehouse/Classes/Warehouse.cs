using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Warehouse
{
	 class Warehouse
	{
		List<Category> _categories = new List<Category>();
		public List<Category> Categories { 
			get => _categories;
			set => _categories = value; 
		}

		public void ExportJson() {
			using (var sw = new StreamWriter("output.json")) {
				sw.Write(JsonSerializer.Serialize(this));
			}
				
		}

		
	}
}
