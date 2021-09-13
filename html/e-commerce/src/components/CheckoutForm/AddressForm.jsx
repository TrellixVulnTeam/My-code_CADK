import React, { useState, useEffect} from 'react';
import {InputLabel, Select, MenuItem, Button, Grid, Typography} from '@material-ui/core';
import {useForm, formProvider} from 'react-hook-form';
import {Link} from 'react-router-dom';

import {commerce} from '../../lib/commerce';
import FormInput from './CustomTextField';
import { addLeadingSlash } from 'history/PathUtils';

const AddressForm = ({checkoutToken, test}) => {
    const [shippingCountries, setShippingCountries] = useState([]);
    const [shippingCountry, setShippingCountry] = useState('');
    const [shippingSubdivisions, setShippingSubdivisions] = useState([]);
    const [shippingSubdivision, setShippingSubdivision] = useState('');
    const [shippingOptions, setShippingOptions] = useState([]);
    const [shippingOption, setShippingOption] = useState('');
    const methods = useForm();

    const fetchShippingCountries = async(checkoutTokenId) => {
        const {countries} = await commerce.services.localeListShippingCountries(checkoutTokenId);

        setShippingCountries(countries);
        setShippingCountry(Object.keys(countries)[0]);
    };

    const fetchSubdivisions = async(countryCode) => {
        const {subdivisions} = await commerce.services.localeListSubdivisions(countryCode);

        setShippingSubdivisions(subdivisions);
        setShippingSubdivision(Object.keys(subdivisions)[0]);
    };
    const fetchShippingOptions = async (checkoutTokenId, country, stateProvince = null) => {
        const options = await commerce.checkout.setShippingOption(checkoutTokenId,{country, region: stateProvince});

        setShippingOptions(options);
        setShippingOption(options[0].id);
    };

    useEffect(() =>{
        if (shippingSubdivision) fetchShippingOptions(checkoutToken.id, shippingCountry, shippingSubdivisions);
    },[shippingSubdivision]);

    return (
        <>
            <Typography varian="h6" gutterBottom>Shipping address</Typography>
            <formProvider {...methods}>
                <form onSubmit={methods.handleSubmit((data) => test({...data, shippingCountry, shippingSubdivision, shippingOption}))}>
                    <Grid container spacing={3}>
                        <FormInput required name="firstName" label="first name"/>
                        <FormInput required name="lastName" label="Last name"/>
                        <FormInput required name="address" label="Address line 1"/>
                        <FormInput required name="email" label="Email" />
                        <FormInput required name="city" label="city"/>
                        <FormInput required name="zip" label="Zip / Postal code" />
                        <Grid item xs={12} sm ={6}>
                            <InputLabel>Shipping Country</InputLabel>
                            <Select value={shippingCountry} fullWidth onChange={(e) => setShippingCountry(e.target.value)}>
                                {Object.entries(shippingSubdivisions).map(([code,name])=>({id:code,label:name})).map((item) =>(
                                    <MenuItem key={item.id} value={item.id}>
                                        {item.label}
                                    </MenuItem>
                                ))}
                            </Select>
                        </Grid>
                        <Grid item xs={12} sm={6}>
                            <InputLabel>Shipping subdivision</InputLabel>
                            <Select value={shippingCountry} fullWidth onChange={(e)=> setShippingCountry(e.target)}>
                                {Object.entries(shippingCountries).map(([code,name])=>({id:code,label:name})).map((item) =>(
                                    <MenuItem key={item.id} value={item.id}>
                                        {item.label}
                                    </MenuItem>
                                ))}
                            </Select>
                        </Grid>
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <InputLabel>Shipping Options</InputLabel>
                        <Select value={shippingOption} fullWidth onChange={(e) => setShippingOption(e.target.value)}>
                            {Object.entries(shippingSubdivisions).map(([code,name]) => ({id: code, label: name})).map((item) => (
                                <MenuItem key={item.id} value={item.id}>
                                    {item.label}
                                </MenuItem>
                            ))}
                        </Select>
                    </Grid>
                    <br/>
                    <div style={{display: 'flex', justifyContent: 'space-between'}}>
                        <Button commerce={Link} variant="outlined" t0="/cart">Back to Cart</Button>
                        <Button type="submit" variant="contained" color="primary">Next</Button>

                    </div>
                </form>
            </formProvider>
        </>
    );
};

export default AddressForm;