import React from 'react';

const BreeedingCard = ({data}) => {
    return (
        <div className='breeding_container'>
            <p style={{fontSize: '32px', marginLeft: '25px'}}>Breeding</p>
            <div className='container_height_weight'>
                <div className='container_height'>
                    <p>Height</p>
                    <div className='container_statistic_height'>
                        <p>0.{data?.height}m</p>
                    </div>
                </div>
                <div className='container_weight'>
                    <p>Weight</p>
                    <div className='container_statistic_weight'>
                        <p>{data?.weight}kg</p>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default BreeedingCard;