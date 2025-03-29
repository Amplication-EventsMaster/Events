import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import { SdfsfService } from "./sdfsf.service";
import { SdfsfControllerBase } from "./base/sdfsf.controller.base";

@swagger.ApiTags("sdfsfs")
@common.Controller("sdfsfs")
export class SdfsfController extends SdfsfControllerBase {
  constructor(protected readonly service: SdfsfService) {
    super(service);
  }
}
