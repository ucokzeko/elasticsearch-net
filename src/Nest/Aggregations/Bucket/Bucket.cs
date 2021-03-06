// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

﻿using System.Collections.Generic;

namespace Nest
{
	public interface IBucket { }

	public abstract class BucketBase : AggregateDictionary, IBucket
	{
		protected BucketBase(IReadOnlyDictionary<string, IAggregate> aggregations) : base(aggregations) { }
	}
}
