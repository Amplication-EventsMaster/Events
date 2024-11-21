import * as graphql from "@nestjs/graphql";
import { SdfsfResolverBase } from "./base/sdfsf.resolver.base";
import { Sdfsf } from "./base/Sdfsf";
import { SdfsfService } from "./sdfsf.service";

@graphql.Resolver(() => Sdfsf)
export class SdfsfResolver extends SdfsfResolverBase {
  constructor(protected readonly service: SdfsfService) {
    super(service);
  }
}
