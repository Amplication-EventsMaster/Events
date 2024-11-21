import { Sdfsf as TSdfsf } from "../api/sdfsf/Sdfsf";

export const SDFSF_TITLE_FIELD = "a";

export const SdfsfTitle = (record: TSdfsf): string => {
  return record.a?.toString() || String(record.id);
};
