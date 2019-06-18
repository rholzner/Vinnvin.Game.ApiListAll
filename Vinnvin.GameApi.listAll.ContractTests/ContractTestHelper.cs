using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Vinnvin.GameApi.listAll.ContractTests
{
    public class ContractTestHelper
    {
        public void ContractTest<T>(dynamic props)
        {
            var modelUndeTest = typeof(T);
            var exsistingProps = modelUndeTest.GetProperties();
            var result = new List<PropAnalyz>();
            foreach (var prop in props)
            {
                string name = prop.Name;

                var exsistingProp = exsistingProps.FirstOrDefault(x => x.Name.ToUpper() == name.ToUpper());
                if (exsistingProp is null)
                {
                    result.Add(new PropAnalyz()
                    {
                        Missing = true,
                        Name = name
                    });
                    continue;
                }

                var type = prop.Value.type.Value;
                string format = "";
                if (!(prop.Value.format is null))
                {
                    format = prop.Value.format.Value;
                }
                if (type == "string" && format == "date-time" && exsistingProp.PropertyType.Name != "DateTime")
                {
                    result.Add(new PropAnalyz()
                    {
                        Name = name,
                        WrongType = true,
                        ExpectedType = format,
                        PropTypeWas = exsistingProp.PropertyType.Name
                    });
                    continue;
                }

                if (type == "string" && string.IsNullOrWhiteSpace(format) && exsistingProp.PropertyType.Name != "String")
                {
                    result.Add(new PropAnalyz()
                    {
                        Name = name,
                        WrongType = true,
                        ExpectedType = type,
                        PropTypeWas = exsistingProp.PropertyType.Name
                    });
                    continue;
                }
                if (type == "boolean" && string.IsNullOrWhiteSpace(format) && exsistingProp.PropertyType.Name != "Boolean")
                {
                    result.Add(new PropAnalyz()
                    {
                        Name = name,
                        WrongType = true,
                        ExpectedType = type,
                        PropTypeWas = exsistingProp.PropertyType.Name
                    });
                    continue;
                }
                result.Add(new PropAnalyz()
                {
                    Name = name
                });
            }

            foreach (var item in result)
            {
                Assert.False(item.Missing, "missing prop: " + item.Name);
                Assert.False(item.WrongType, "wrong type prop " + item.Name + " should be " + item.ExpectedType + " but was " + item.PropTypeWas);
            }
        }
    }
}

