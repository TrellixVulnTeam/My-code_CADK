import React from 'react';
import {Typography, Button, Card, CardActions, CardContent, CardMedia } from '@material-ui/core';

import useStyles from './styles';

const CartItem = ({item, onUpdateCartQty, onRemoveFromCart}) => {
    const classes = useStyles();

    const handleUpdateCartQty = (lineItemId, newQuantity) => onUpdateCartQty(lineItemId, newQuantity);

    const hanbleRemoveFromCart = (lineItemId) => onRemoveFromCart(lineItemId);

    return (
        <Card className="Cart-item">
            <CardMedia image={item.media} alt={item.name} className={classes.media} />
            <CardContent className={classes.CardContent}>
                <Typography variant="h4">{item.name}</Typography>
                <Typography variant="h5">{item.line_total.formatted_with_symbol}</Typography>
            </CardContent>
            <CardActions className={classes.CardActions}>
                <div className={classes.buttons}>
                    <Button type="button" size="small" onClick={() => handleUpdateCartQty(item.id, item.quantity - 1)}>-</Button>
                    <Typography>&nbsp;{item.quantity}&nbsp</Typography>
                    <Button type="button" size="small" onClick={() => handleUpdateCartQty(item.id,item.quantity + 1)}>+</Button>
                </div>
                <Button variant="container" type="button" color="secondary" onClick={() => hanbleRemoveFromCart(item.id)}>Remove</Button>
            </CardActions>
        </Card>
    );
};

export default CartItem;