﻿using System.Collections.Generic;
using TrainingPortal.Client.TestService;

namespace TrainingPortal.Models
{
	public class TestOption
	{
		public string Id { get; set; }
		public bool IsChecked { get; set; }
		public string Name { get; set; }

		//From TestService
		//public static implicit operator TestOption(TrainingPortal.Client.TestService.TestOptionDto option)
		//{
		//	if (option != null)
		//	{
		//		return new TrainingPortal.Client.TestService.TestOptionDto()
		//		{
		//			Id = option.Id,
		//			Name = option.Name,
		//			IsChecked = option.IsChecked
		//		};
		//	}

		//	return null;
		//}

		//public static implicit operator TrainingPortal.Client.TestService.TestOptionDto(TestOption option)
		//{
		//	if (option != null)
		//	{
		//		return new TrainingPortal.Client.TestService.TestOptionDto()
		//		{
		//			Id = option.Id,
		//			Name = option.Name,
		//			IsChecked = option.IsChecked
		//		};
		//	}

		//	return null;
		//}

		//From TestOptionService
		public static implicit operator TestOption(TrainingPortal.Client.TestOptionService.TestOptionDto option)
		{
			if (option != null)
			{
				return new TestOption()
				{
					Id = option.Id,
					Name = option.Name,
					IsChecked = option.IsChecked
				};
			}

			return null;
		}

		public static implicit operator TrainingPortal.Client.TestOptionService.TestOptionDto(TestOption option)
		{
			if (option != null)
			{
				return new TrainingPortal.Client.TestOptionService.TestOptionDto()
				{
					Id = option.Id,
					Name = option.Name,
					IsChecked = option.IsChecked
				};
			}

			return null;
		}
	}
}