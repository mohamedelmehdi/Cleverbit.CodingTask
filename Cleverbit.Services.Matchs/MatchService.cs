using System;
using System.Collections.Generic;
using System.Text;

namespace Cleverbit.Services.Match
{
    public class MatchService
    {
        private readonly 
        public MatchService(
    IServiceScopeFactory factory,
    ICoachingStructuresService coachingStructuresService,
    ICoachingTemplatesService coachingTemplatesService,
    IDbRepository dbRepository,
    ITimeZoneConverter converter,
    IOptimizedIncludeWrapper optimizedIncludeWrapper

) : base(factory, dbRepository)
        {
            svcCoachingStructures = coachingStructuresService;
            svcCoachingTemplates = coachingTemplatesService;
            timeZoneConverter = converter;
            includeWrapper = optimizedIncludeWrapper;

        }
    }
}
