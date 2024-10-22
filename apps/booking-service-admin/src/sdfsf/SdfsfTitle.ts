import { Sdfsf as TSdfsf } from "../api/sdfsf/Sdfsf";

export const SDFSF_TITLE_FIELD = "id";

export const SdfsfTitle = (record: TSdfsf): string => {
  return record.id?.toString() || String(record.id);
};
