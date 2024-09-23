using Microsoft.AspNetCore.Mvc;
using ServiceGamma.APIs.Common;
using ServiceGamma.Infrastructure.Models;

namespace ServiceGamma.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class HelloFindManyArgs : FindManyInput<Hello, HelloWhereInput> { }
