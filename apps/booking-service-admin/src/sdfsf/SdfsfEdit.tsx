import * as React from "react";
import { Edit, SimpleForm, EditProps, TextInput } from "react-admin";

export const SdfsfEdit = (props: EditProps): React.ReactElement => {
  return (
    <Edit {...props}>
      <SimpleForm>
        <TextInput label="a" source="a" />
      </SimpleForm>
    </Edit>
  );
};
