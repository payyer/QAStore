import { AppBar, Switch, Toolbar, Typography } from "@mui/material";

interface Props {
  changeMode: () => void;
}
export default function Header({ changeMode }: Props) {
  return (
    <AppBar position="static" sx={{ mb: 4 }}>
      <Toolbar>
        <Typography>QA-Store</Typography>
        <Switch onChange={changeMode} />
      </Toolbar>
    </AppBar>
  );
}
