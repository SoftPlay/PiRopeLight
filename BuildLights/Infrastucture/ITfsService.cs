﻿namespace Infrastucture
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

    public interface ITfsService
    {
		Task<IQueryable<string>> GetCompletedBuilds(string project);
    }
}