import Catalog from "../../components/catalog/Catalog";
import { Container, createTheme, ThemeProvider } from "@mui/material";
import Header from "./Header";
import { useState } from "react";

function App() {
  const [darkMode, setDarkMode] = useState<boolean>(false);
  function changeMode() {
    setDarkMode(!darkMode);
  }
  const paletteType = darkMode ? "dark" : "light";

  const theme = createTheme({
    palette: {
      mode: paletteType,
    },
  });

  return (
    <ThemeProvider theme={theme}>
      <Header changeMode={changeMode} />
      <Container>
        <Catalog />
      </Container>
    </ThemeProvider>
  );
}

export default App;
