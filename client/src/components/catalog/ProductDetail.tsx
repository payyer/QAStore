import { useEffect, useState } from "react";
import { useParams } from "react-router";
import { Product } from "../../app/models/product";
import axios from "axios";
import Grid from "@mui/material/Grid2";
import {
  Divider,
  Table,
  TableCell,
  TableContainer,
  TableRow,
  Typography,
} from "@mui/material";

export default function ProductDetail() {
  const { id } = useParams<{ id: string }>();
  const [products, setProducts] = useState<Product | null>(null);
  const [loading, setLoading] = useState<boolean>(true);
  useEffect(() => {
    axios
      .get(`http://localhost:5163/api/Products/${id}`)
      .then((res) => setProducts(res.data))
      .catch((err) => console.log({ err }))
      .finally(() => {
        setLoading(false);
      });
  }, [id]);
  if (loading) return <>Loading...</>;
  if (!products) return <>Not Found 404</>;
  return (
    <Grid container spacing={6}>
      <Grid size={6}>
        <img
          src={products.pictureUrl}
          alt={products.name}
          loading="lazy"
          style={{ width: "100%", height: "auto" }}
        />
      </Grid>
      <Grid size={6}>
        <Typography variant="h2">{products.name}</Typography>
        <Divider />
        <TableContainer>
          <Table>
            <TableRow>
              <TableCell>Price:</TableCell>
              <TableCell sx={{ color: "secondary.main", fontWeight: "bold" }}>
                ${(products.price / 100000).toFixed(2)}
              </TableCell>
            </TableRow>
            <TableRow>
              <TableCell>Brand:</TableCell>
              <TableCell>{products.brand}</TableCell>
            </TableRow>
            <TableRow>
              <TableCell>Description:</TableCell>
              <TableCell>{products.description}</TableCell>
            </TableRow>
            <TableRow>
              <TableCell>Type:</TableCell>
              <TableCell>{products.type}</TableCell>
            </TableRow>
          </Table>
        </TableContainer>
      </Grid>
    </Grid>
  );
}
