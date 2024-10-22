import { Module } from "@nestjs/common";
import { SdfsfModuleBase } from "./base/sdfsf.module.base";
import { SdfsfService } from "./sdfsf.service";
import { SdfsfController } from "./sdfsf.controller";
import { SdfsfResolver } from "./sdfsf.resolver";

@Module({
  imports: [SdfsfModuleBase],
  controllers: [SdfsfController],
  providers: [SdfsfService, SdfsfResolver],
  exports: [SdfsfService],
})
export class SdfsfModule {}
