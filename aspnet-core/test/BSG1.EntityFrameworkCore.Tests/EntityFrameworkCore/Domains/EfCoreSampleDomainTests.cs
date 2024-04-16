using BSG1.Samples;
using Xunit;

namespace BSG1.EntityFrameworkCore.Domains;

[Collection(BSG1TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BSG1EntityFrameworkCoreTestModule>
{

}
