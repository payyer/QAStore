import Catalog from "../../components/catalog/Catalog";
import {
  Container,
  createTheme,
  CssBaseline,
  ThemeProvider,
} from "@mui/material";
import Header from "./Header";
import { useState } from "react";
import HomePage from "../../components/home/HomePage";
import AboutPage from "../../components/about/AboutPage";
import ContactPage from "../../components/contact/ContactPage";
import { Route, Routes } from "react-router";
import ProductDetail from "../../components/catalog/ProductDetail";

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
      <CssBaseline />
      <Header changeMode={changeMode} />
      <Container>
        <Routes>
          <Route index element={<HomePage />} />
          <Route path="/catalog" element={<Catalog />} />
          <Route path="/catalog/:id" element={<ProductDetail />} />
          <Route path="/about" element={<AboutPage />} />
          <Route path="/contact" element={<ContactPage />} />
        </Routes>
      </Container>
    </ThemeProvider>
  );
}

export default App;
