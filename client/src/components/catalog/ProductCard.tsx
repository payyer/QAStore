import {
  Box,
  Button,
  Card,
  CardActions,
  CardContent,
  CardHeader,
  CardMedia,
  Typography,
} from "@mui/material";
import { Product } from "../../app/models/product";
import { Link } from "react-router";

interface Props {
  product: Product;
}
export default function ProductCard({ product }: Props) {
  return (
    <Card>
      <CardHeader
        title={product.name}
        slotProps={{
          title: { sx: { fontWeight: "bold", color: "primary.main" } },
        }}
      />
      <CardMedia
        sx={{ height: 140 }}
        image="/static/images/cards/contemplative-reptile.jpg"
        title="green iguana"
      />
      <CardContent>
        <Typography gutterBottom variant="subtitle1" component="div">
          {product.brand} / {product.type}
        </Typography>
        <Typography variant="body2" sx={{ color: "text.secondary" }}>
          {product.description}
        </Typography>
      </CardContent>
      <Box
        sx={{
          display: "flex",
          justifyContent: "space-between",
          alignItems: "center",
          paddingX: 2,
        }}
      >
        <Typography variant="subtitle2" sx={{ color: "text.primary" }}>
          ${(product.price / 1000000).toFixed(2)}
        </Typography>
        <CardActions>
          <Button component={Link} to={`/catalog/${product.id}`} size="small">
            View
          </Button>
          <Button size="small">Add to card</Button>
        </CardActions>
      </Box>
    </Card>
  );
}
