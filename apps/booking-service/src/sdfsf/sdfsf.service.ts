import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { SdfsfServiceBase } from "./base/sdfsf.service.base";

@Injectable()
export class SdfsfService extends SdfsfServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
