import React, { useEffect, useState } from "react";
import { Admin, DataProvider, Resource } from "react-admin";
import dataProvider from "./data-provider/graphqlDataProvider";
import { theme } from "./theme/theme";
import Login from "./Login";
import "./App.scss";
import Dashboard from "./pages/Dashboard";
import { SdfsfList } from "./sdfsf/SdfsfList";
import { SdfsfCreate } from "./sdfsf/SdfsfCreate";
import { SdfsfEdit } from "./sdfsf/SdfsfEdit";
import { SdfsfShow } from "./sdfsf/SdfsfShow";
import { jwtAuthProvider } from "./auth-provider/ra-auth-jwt";

const App = (): React.ReactElement => {
  return (
    <div className="App">
      <Admin
        title={"Booking Service"}
        dataProvider={dataProvider}
        authProvider={jwtAuthProvider}
        theme={theme}
        dashboard={Dashboard}
        loginPage={Login}
      >
        <Resource
          name="Sdfsf"
          list={SdfsfList}
          edit={SdfsfEdit}
          create={SdfsfCreate}
          show={SdfsfShow}
        />
      </Admin>
    </div>
  );
};

export default App;
