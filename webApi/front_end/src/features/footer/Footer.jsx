// @ts-nocheck
import React, { useEffect } from 'react'
import { Link } from 'react-router-dom'
import { useSelector, useDispatch } from 'react-redux'
import { selectAllFooterLinks } from './footerSlice'
import { AddEmail, fetchEmails, selectAllEmails } from './../components/form/emailsSlice'
import styles from './footer.module.css'
import RoundedButton from '../toolbox/buttons/RoundedButton'

const Footer = () =>
{
    const allFooterData = useSelector( selectAllFooterLinks );
    // const allEmails = useSelector( selectAllEmails );


    const [ email, setEmail ] = React.useState();
    const [ error, setError ] = React.useState();

    const dispatch = useDispatch();

    // const handleNavigateFooter = ( paramsLink ) =>
    // {
    // }

     const sendEmail = () =>
     {
    //     if ( !email )
    //     {
    //         setError( 'Email is required' );
    //         setTimeout( () => setError( '' ), 2000 )
    //     } else
    //     {
            
    //     }
     }

    // useEffect( () =>
    // {
    //     dispatch( fetchEmails() );
    // }, [ dispatch, allEmails ] );

    const renderedMenu = allFooterData.map( ( item ) =>
    {
        return (
            <div className='mt-mb-2 sm-mb-4-padding'>
                {
                    <div key={item.id} className=''>
                        <p
                            className={`${ styles.margin_bottom_paragraph } ${ styles.list_item_header }`}
                        >
                            {item.header}
                        </p>
                        {
                            <ul>
                                {item.headerItems.map( items =>
                                {
                                    return (
                                        <li className={`${ styles.list_item_footer }`}>
                                            <Link to={items[ 1 ]} className="text-decoration-none text-white">{items[ 0 ]}</Link>
                                        </li>
                                    )
                                } )}
                            </ul>
                        }
                    </div>
                }
            </div>
        )
    } )

    return (
        <div className={`${ styles.footer_height } display-mb-flex flex-mb-column`}>
            <div className={styles.upper_content}>
                <div
                    className={`d-flex justify-between ${ styles.width_footer_links } flex-mb-column relative`}
                >
                    <h2 className={styles.footer_header}>
                        Uğura gedən <br />
                        yolda TWC ilə
                    </h2>
                    <div className='mb-self-end'>
                        <RoundedButton positioned="40px" onClick={sendEmail} />
                    </div>
                    <input
                        type="email"
                        name="email"
                        id="email"
                        placeholder={error && error.length > 0 ? error : 'Email'}
                        pattern="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"
                        className={`absolute ${ styles.footer_input }`}
                        value={email}
                        onChange={( e ) => setEmail( e.target.value )}
                    />
                </div>

                <div
                    className={`d-flex justify-between ${ styles.margin_top_content } ${ styles.width_footer_links }`}
                >
                    {renderedMenu}
                </div>
            </div>
            <p className={styles.footer_end}>&copy; 2021 Think Wise Consulting MMC</p>
        </div>
    )
}

export default Footer