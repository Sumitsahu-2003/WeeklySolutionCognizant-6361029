import React from 'react';
import styles from './Components/CohortDetails.module.css'; // Make sure path is correct

function CohortDetails(props) {
    const cohort = props.cohort;

    return (
        <div className={styles.box}>
            <h3 style={{ color: cohort.status === 'ongoing' ? 'green' : 'blue' }}>
                {cohort.name}
            </h3>

            <dl>
                <dt>Started On</dt>
                <dd>{cohort.startDate}</dd>
                <dt>Current Status</dt>
                <dd>{cohort.currentStatus}</dd>
                <dt>Coach</dt>
                <dd>{cohort.coachName}</dd>
                <dt>Trainer</dt>
                <dd>{cohort.trainerName}</dd>
            </dl>
        </div>
    );
}

export default CohortDetails;
