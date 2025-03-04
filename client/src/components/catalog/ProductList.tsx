import Grid from "@mui/material/Grid2";
import { Product } from "../../app/models/product";
import ProductCard from "./ProductCard";

interface Props {
  products: Product[];
}

export default function ProductList({ products }: Props) {
  return (
    <Grid container spacing={2}>
      {products.map((product) => {
        return (
          <Grid key={product.id} size={4}>
            <ProductCard key={product.id} product={product} />
          </Grid>
        );
      })}
    </Grid>
  );
}
